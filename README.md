# Hotel Reservation System

Este é um projeto simples de gerenciamento de reservas de hotel em **C#**, utilizando **POO** (Programação Orientada a Objetos).  
O sistema permite criar hóspedes, suítes e reservas, além de calcular o valor total de uma reserva e validar a capacidade da suíte.

---

## Funcionalidades

- Criar hóspedes (`Customer`) com nome e sobrenome.  
- Criar suítes (`Suite`) com tipo, capacidade e preço por noite.  
- Criar reservas (`Reservation`) com lista de hóspedes, suíte e quantidade de dias.  
- Validar se o número de hóspedes não ultrapassa a capacidade da suíte.  
- Calcular o valor total da reserva, aplicando desconto automático para reservas acima de 10 dias.

---

## Estrutura do Projeto

O projeto está organizado em três classes principais:

1. **Customer** – Representa um hóspede do hotel.  
2. **Suite** – Representa uma suíte do hotel, com tipo, capacidade e preço por noite.  
3. **Reservation** – Representa uma reserva, contendo hóspedes, suíte e duração, além de métodos para validação e cálculo do preço total.

---

## Diagrama de Classes
![Diagrama de Classes](https://github.com/digitalinnovationone/trilha-net-explorando-desafio/blob/main/diagrama_classe_hotel.png)
