# Sistema de Celulares - Abstração e Polimorfismo com .NET

Solução para o desafio de projeto **"Abstraindo um Celular"** da trilha .NET da **DIO**.

## 🎯 Objetivo do Projeto
O objetivo principal foi estruturar um sistema orientado a objetos que abstrai o funcionamento básico de celulares, permitindo comportamentos específicos para diferentes marcas (Nokia e iPhone) através de herança e polimorfismo.

## 🏗️ Arquitetura e Conceitos Aplicados

O projeto foi estruturado com base nos seguintes pilares da POO:

1.  **Abstração:** Criação da classe base `Smartphone` que define o contrato (propriedades e métodos) que todo celular deve ter, mas não pode ser instanciada diretamente.
2.  **Herança:** As classes `Nokia` e `Iphone` herdam as características de `Smartphone` (Número, Modelo, IMEI, Memória).
3.  **Polimorfismo:** Sobrescrita do método abstrato `InstalarAplicativo`, permitindo que cada marca tenha sua própria implementação (lógica) de instalação.
4.  **Encapsulamento:** Proteção dos dados sensíveis e acesso controlado via construtores e propriedades.

### Diagrama de Classes (Referência)
O sistema segue a estrutura proposta:
* **Smartphone (Abstrata):** Classe pai.
* **Nokia (Concreta):** Classe filha.
* **Iphone (Concreta):** Classe filha.

## 🛠️ Tecnologias
* **C#**
* **.NET** (Console Application)

## 🚀 Como Executar
1. Clone este repositório.
2. Abra o projeto no VS Code ou Visual Studio.
3. Execute o comando no terminal:

```bash
dotnet run