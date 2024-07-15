*Venham! Vejam as obras do Senhor, seus feitos estarrecedores na terra. Salmos 46:8*
![post-fast-end-net](https://github.com/user-attachments/assets/01c4aa82-5bb3-4f35-b364-d423577cd70c)

O titulo se dá ao nome *fast endpoints started aspnet*, que tem por base da construção [FastEndpoints](https://fast-endpoints.com/)

## Índice

1. [Visão Geral](#visão-geral)
2. [Instalação](#instalação)
3. [Como Usar](#como-usar)
4. [Configuração](#configuração)
5. [Contribuições](#contribuições)
6. [Referências](#referências)

## Visão Geral

Embora tenho seguido como sugere a documentação, por conta realizei algumas implementações autorais.

## Instalação

### Windows

#### .NET Framework

1. **Verificar a versão do Windows:**
   - Abra o "Painel de Controle" e vá para "Programas" > "Programas e Recursos". Lá você pode ver se o .NET Framework já está instalado e qual versão.

2. **Instalação:**
   - Para instalar o .NET Framework, baixe o instalador adequado para a versão do Windows no site da Microsoft (geralmente pode ser encontrado como um componente opcional no Windows Update).

#### .NET Core / .NET 5.0 e posteriores

1. **Baixar o instalador:**
   - Acesse o site [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) e baixe o instalador do .NET Core ou .NET 5.0 (ou versão posterior).

2. **Executar o instalador:**
   - Execute o arquivo baixado e siga as instruções na tela para completar a instalação.

### macOS

#### .NET Core / .NET 5.0 e posteriores

1. **Baixar o instalador:**
   - Acesse o site [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) e baixe o instalador do .NET Core ou .NET 5.0 (ou versão posterior) para macOS.

2. **Executar o instalador:**
   - Abra o arquivo baixado (.pkg) e siga as instruções na tela para completar a instalação.

### Linux

#### .NET Core / .NET 5.0 e posteriores

1. **Adicionar o repositório do .NET:**
   - Siga as instruções específicas para sua distribuição Linux no site da Microsoft [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

2. **Instalar o .NET:**
   - Use os comandos apropriados para sua distribuição Linux para instalar o .NET Core ou .NET 5.0 e posteriores. Por exemplo, para Ubuntu:
     ```bash
     sudo apt-get update
     sudo apt-get install dotnet-sdk-5.0
     ```

3. **Verificar a instalação:**
   - Após a instalação, você pode verificar se o .NET foi instalado corretamente usando o comando:
     ```bash
     dotnet --version
     ```

### Observações gerais

- **Atualizações:** É recomendável manter o .NET atualizado para receber correções de segurança e novos recursos.
- **Documentação:** Para instruções detalhadas e específicas para diferentes versões e cenários, consulte a documentação oficial da Microsoft em [docs.microsoft.com/dotnet](https://docs.microsoft.com/dotnet).

Seguindo esses passos, você conseguirá instalar o .NET em diferentes sistemas operacionais de forma adequada.

## Como Usar

As instalações foram seguidas conforme a documentação. Acrescentando um pacote à mais.

![image](https://github.com/daniloopinheiro/fast-endpoints-started-aspnet/assets/64677271/d887a057-0902-4422-8ec4-773759e04f0a)


```bash
$ dotnet add package FastEndpoints
$ dotnet add package FastEndpoints.Swagger
```

## Configuração

Conforme o projeto está, não há nenhuma necessidade de configurar; apenas verificar a versão do sdk em sua maquina que esteja instalado.

## Contribuições

- https://github.com/FastEndpoints

## Referências:

- https://fast-endpoints.com/
- https://dev.to/djnitehawk/building-rest-apis-in-net-6-the-easy-way-3h0d
- https://deviq.com/design-patterns/repr-design-pattern
