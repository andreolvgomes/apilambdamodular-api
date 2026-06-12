# 🚀 ApiLambdaModular (FastEndpoints + AWS Lambda)

Este projeto implementa uma arquitetura de **Micro-monolitos por Módulo (Lambda-liths)** utilizando .NET, FastEndpoints e AWS Lambda (HttpApi). A proposta é unir o melhor do desenvolvimento organizado (DDD/Modular) com o poder elástico e econômico do Serverless.

---

## 🧠 A Arquitetura e a Dupla Escala Horizontal

O projeto é fatiado em módulos independentes na AWS, proporcionando duas camadas de escalabilidade:

1. **Escala Estrutural (Isolamento de Negócio):** O API Gateway atua como um roteador de tráfego usando a regra de *Maior Coincidência de Prefixo*. Isso significa que cada grande módulo de negócio roda em sua própria AWS Lambda, isolando falhas, recursos e deploys.
2. **Escala de Infraestrutura (Serverless Elástico):** Cada Lambda escala instâncias horizontalmente de forma automática e independente de acordo com o volume de requisições de cada endpoint.

---

## 🚦 Roteamento no API Gateway

O tráfego é distribuído pelo API Gateway seguindo a especificidade das rotas:

```mermaid
graph TD
    Request([Requisição HTTP]) --> API[API Gateway Central]
    API -->|/orcamentos/*| L1[Lambda Orçamentos]
    API -->|/orcamentos/itens/*| L2[Lambda Itens]
    API -->|/orcamentos/pagamentos/*| L3[Lambda Pagamentos]
	API -->|/vendas/*| L1[Lambda Vendas]
    API -->|/vendas/itens/*| L2[Lambda Itens]
    API -->|/vendas/pagamentos/*| L3[Lambda Pagamentos]