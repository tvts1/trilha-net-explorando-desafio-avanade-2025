using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// --- Criando hóspedes ---
var guests = new List<Customer>
{
    new Customer("Adam", "Sandler"),
    new Customer("Cleiton", "Rasta"),
    new Customer("Tiago", "Miguel")
};

// --- Criando suíte ---
var suite = new Suite(suiteType: "Premium", capacity: 2, pricePerNight: 30m);

// --- Criando reserva ---
var reservation = new Reservation(
    guests: guests,
    suite: suite,
    reservationDays: 5
);

// --- Exibindo informações ---
Console.WriteLine($"Hóspedes: {reservation.GetGuestsQuantity}");
Console.WriteLine($"Valor total da reserva: {reservation.CalculateTotalPrice():C}");
