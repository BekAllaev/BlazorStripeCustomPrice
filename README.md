# BlazorStripe

## Description
In this project my idea is to send request to Stripe with the price and product name. I expect that this price and product name will be on the checkout page.   
In any case Stripe returns user to the form in my project whether it successfull or not successfull payment.

This repo is based on this article - https://jonhilton.net/blazor-stripe/.  
In this repo we use webhooks, here is the article about webhook principles - https://hookdeck.com/webhooks/guides/what-are-webhooks-how-they-work#:~:text=A%20webhook%20is%20an%20HTTP,fired%20in%20the%20source%20system.  
This is webhook implementation in ASP .NET Core - https://learn.microsoft.com/en-us/aspnet/webhooks/

> There is no need to configure price or the product on the Stripe

## Project structure

This is Blazor Web App(auto render mode)

Class libraries:
- `StripeModule.Backend` - contains backend logic that is related to Stripe. For example you will find there web hooks
- `StripeModule.Frontend` - contains frontend logic that is realted to Stripe. Here you will find forms that are shown if payment was accepted successfully or not

Blazor projects:
- `BlazorStripe` - Blazor server part, nothing interesting here.
- `BlazorStripe.Client` - Blazor client part. Contains core logic. You will find code on `Home.razor`. You should consume `StripeModule.Frontend` in this project

Backend:
- `BlazorStripe.Backend` - In this project we generate link to the checkout link, also here we consume `StripeModule.Backend`
