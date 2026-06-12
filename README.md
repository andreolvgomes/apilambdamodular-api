# 🚀 ApiLambdaModular (FastEndpoints + AWS Lambda-lith)

Uma arquitetura **Lambda-liths por Módulo** desenhada para **empresas iniciando na nuvem com aplicações satélite** que buscam **custo zero de servidor ocioso** (sem gastar com EC2/Docker fixo).

O modelo preserva o ritmo de entrega da equipe e o conhecimento em APIs convencionais .NET, tratando cada Lambda como um micromonolito independente de domínio.

---

## 💥 O Problema do Passado vs. ✨ A Abordagem Lambda-lith

* **Antes (Uma Lambda por Função):** A produção do time caía porque criar funções isoladas travava os testes locais e gerava um arquivo `template.yaml` gigante de 150 endpoints, impossível de manter.
* **Agora (Lambda-lith):** Cada Lambda encapsula um módulo completo de negócio rodando como uma API convencional. O desenvolvedor testa tudo localmente dando *Play* no IDE, enquanto a infraestrutura na nuvem permanece enxuta e centralizada por grandes blocos de domínio.

---

## 🛠️ Tecnologias Fundamentais da Arquitetura

Para manter cada **Lambda-lith** rodando de forma leve e performática, focamos em 5 pilares:

* **AWS API Gateway:** Atua como o roteador central. Usa a regra de *Maior Coincidência de Prefixo* para direcionar o tráfego de forma inteligente para o Lambda-lith correto (ex: `/vendas/*` vai para um módulo, `/vendas/itens/*` vai para outro).
* **AWS Lambda (Como Deploy de API / Lambda-lith):** Executa o sub-monolito .NET de forma 100% serverless. Escala instâncias horizontalmente de forma automática e independente por módulo, cobrando apenas pelos milissegundos de uso.
* **Proxy Integration (AWS Lambda Hosting):** Conecta o API Gateway diretamente ao motor do ASP.NET Core, permitindo que o Lambda-lith receba e responda requisições HTTP nativas com baixíssima latência.
* **FastEndpoints:** Organiza o código interno do Lambda-lith, substituindo Controllers inflados. Garante o isolamento estrito usando o padrão **REPR (Request-Endpoint-Response)** — cada rota é uma classe isolada e enxuta.
* **`template.yaml` (AWS SAM/CloudFormation):** Utilizado estritamente para provisionar os grandes blocos de Lambda-liths e rotas do API Gateway de forma declarativa e limpa, mantendo o arquivo pequeno e legível.

---

## 🧠 A Dupla Escala Horizontal

1. **Escala Estrutural (Domínio):** Se o Lambda-lith de Pagamentos explodir em acessos, apenas ele sofre o impacto. Os Lambda-liths de Vendas e Itens continuam isolados e estáveis.
2. **Escala de Infraestrutura (Serverless):** A AWS cria e destrói instâncias automaticamente para cada Lambda-lith em milissegundos, acompanhando o pico de acessos perfeitamente.

---

## 🚦 Roteamento de Módulos

```mermaid
graph TD
    Request([Requisição HTTP]) --> API[API Gateway]
    API -->|/vendas/*| L1[Lambda-lith Vendas]
    API -->|/vendas/itens/*| L2[Lambda-lith Itens]
    API -->|/vendas/pagamentos/*| L3[Lambda-lith Pagamentos]