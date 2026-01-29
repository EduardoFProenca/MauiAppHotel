# 🏨 MauiAppHotel

Aplicativo mobile multiplataforma para cálculo de diárias e reservas de hotel, desenvolvido com .NET MAUI.

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como **Agenda 14** da disciplina de **Desenvolvimento de Sistemas II** na ETEC, sob orientação do professor **Argeli Pedro de Lima**. O aplicativo é focado em criar uma solução mobile para gerenciamento de hospedagens em hotéis, permitindo que usuários calculem o valor de suas estadias com base no tipo de suíte, número de hóspedes e período de permanência.

### 🎓 Informações Acadêmicas

- **Disciplina**: Desenvolvimento de Sistemas II
- **Atividade**: Agenda 14 - Avaliação
- **Professor**: Argeli Pedro de Lima
- **Data da Avaliação**: 02/06/2025
- **Menção**: MB (Muito Bom)
- **Feedback do Professor**: "As alterações feitas no Design ficaram ótimas e deixaram seu Aplicativo bem diferenciado, além dos códigos terem funcionado corretamente. Parabéns."

## 📸 Screenshots

*(Adicione aqui capturas de tela do aplicativo quando disponíveis)*

## ✨ Funcionalidades

- **Cálculo de Diárias**: Sistema inteligente que calcula o valor total da hospedagem
- **Seleção de Suítes**: 4 opções de acomodação:
  - Suíte Super Luxo
  - Suíte Luxo
  - Suíte Single
  - Suíte Crise
- **Gestão de Hóspedes**: Contabilização diferenciada para adultos e crianças (até 13 anos)
- **Seleção de Datas**: Sistema de check-in e check-out com validações
- **Resumo da Reserva**: Visualização completa dos dados da hospedagem contratada
- **Sobre o App**: Informações sobre o desenvolvedor e empresa

## 🏗️ Estrutura do Projeto

```
MauiAppHotel/
├── Models/
│   └── Quarto.cs                    # Modelo de dados para quartos
├── Views/
│   ├── ContratacaoHospedagem.xaml   # Tela de reserva
│   ├── HospedagemContratada.xaml    # Resumo da reserva
│   └── HospedagemSobre.xaml         # Sobre o app
├── Resources/
│   ├── Fonts/                       # Fontes customizadas
│   ├── Images/                      # Imagens e ícones
│   └── Styles/                      # Estilos e cores
├── App.xaml                         # Configurações globais
├── AppShell.xaml                    # Navegação shell
└── MainPage.xaml                    # Página inicial
```

## 🛠️ Tecnologias Utilizadas

- **.NET 9.0**
- **.NET MAUI** (Multi-platform App UI)
- **C#**
- **XAML**
- **Visual Studio 2022**

## 📱 Plataformas Suportadas

- ✅ Android
- ✅ iOS
- ✅ macOS (Catalyst)
- ✅ Windows



## 💰 Tabela de Valores

| Tipo de Suíte      | Diária Adulto | Diária Criança |
|--------------------|---------------|----------------|
| Super Luxo         | R$ 180,00     | R$ 120,00      |
| Luxo               | R$ 150,00     | R$ 100,00      |
| Single             | R$ 120,00     | R$ 75,00       |
| Crise              | R$ 90,00      | R$ 50,00       |

## 🚀 Como Executar

### Pré-requisitos

- Visual Studio 2022 (versão 17.13 ou superior)
- .NET 9.0 SDK
- Workload do .NET MAUI instalado

### Passos para Execução

1. **Clone o repositório**
```bash
git clone [url-do-repositorio]
```

2. **Abra o projeto**
```bash
cd MauiAppHotel
```

3. **Abra a solução no Visual Studio**
```bash
start MauiAppHotel.sln
```

4. **Selecione a plataforma de destino** (Android, iOS, Windows, etc.)

5. **Execute o projeto** (F5)

## 🎨 Design e Interface

O aplicativo utiliza um esquema de cores personalizado:
- **Cor Principal**: #23507a (Azul escuro)
- **Cor Secundária**: #cac7bb (Bege)
- **Background**: Preto
- **Fonte Principal**: Chewy-Regular

### 🌟 Destaques do Design

De acordo com o feedback do professor, as **alterações no design** foram um diferencial importante do projeto:
- Interface visual única e diferenciada
- Combinação harmônica de cores (azul escuro, bege e preto)
- Uso criativo da fonte Chewy-Regular para uma identidade visual marcante
- Layout responsivo e intuitivo

## 📐 Características Técnicas

### Validações Implementadas

- ✅ Data de check-in não pode ser anterior à data atual
- ✅ Data de check-out deve ser posterior ao check-in
- ✅ Limite de até 2 meses de antecedência para reserva
- ✅ Período máximo de estadia de 6 meses
- ✅ Número mínimo de adultos: 1
- ✅ Número máximo de adultos: 10
- ✅ Número máximo de crianças: 20

### Navegação

O app utiliza o padrão Shell Navigation do MAUI, proporcionando:
- Navegação fluida entre páginas
- Flyout menu configurável
- Rotas nomeadas para fácil manutenção

## ✅ Qualidade e Testes

O projeto foi desenvolvido com foco em qualidade de código e funcionalidade:
- ✅ **Todos os códigos funcionando corretamente** (validado pelo professor)
- ✅ Tratamento de exceções em todas as navegações
- ✅ Validações de dados de entrada
- ✅ Interface responsiva e adaptável
- ✅ Código limpo e bem estruturado



<div align="center">

---
**Desenvolvido com 💙 por Eduardo Ferreira Proença**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/eduardo-ferreira-39106b26a)
[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/EduardoFProenca)
[![Gmail](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:eduardo.ferreira.proenca.brasil@gmail.com)


⭐ **Se este repositório foi útil, considere dar uma estrela!** ⭐

</div>


---
