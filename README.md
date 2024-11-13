# BlazorStripe

## Idea of the project
In this project my idea is to send request to Stripe with the price and product name. I expect that this price and product name will be on the checkout page.   
In any case Stripe returns user to the form in my project whether it successfull or not successfull payment.

## Project structure

This is Blazor Web App(auto render mode)

Class libraries:
- `StripeModule.Backend` - contains backend logic that is related to Stripe. For example you will find there web hooks
- `StripeModule.Frontend` - contains frontend logic that is realted to Stripe. Here you will find forms that are shown if payment was accepted successfully or not

Blazor projects:
- `BlazorStripe` - Blazor server part, nothing interesting here.
- `BlazorStripe.Client` - Blazor client part. Contains core logic. You will find code on `Home.razor`. You should consume `StripeModule.Frontend` in this project

Backend:
- `BlazorStripe.Backend` - this is absolutly empty project, generated from template, you won't find anything interesting here. Treat it as stub. This project demonstrate how you can consume  `StripeModule.Backend`
