# SW.I18nServices

[![Build & NuGet Publish](https://github.com/simplify9/SW-I18nServices/actions/workflows/nuget-publish.yml/badge.svg)](https://github.com/simplify9/SW-I18nServices/actions/workflows/nuget-publish.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![NuGet: SimplyWorks.I18n.Service](https://img.shields.io/nuget/v/SimplyWorks.I18n.Service.svg?label=NuGet)](https://www.nuget.org/packages/SimplyWorks.I18n.Service)

A comprehensive .NET library for internationalization (I18n) services including country data, currency conversion, and phone number validation.

## Features

### Countries Service
- Country information with ISO codes, names, and capitals
- Phone number formats and regex patterns
- Postal code formats and validation rules
- Currency information per country
- Language and top-level domain data
- Economic alliance information

### Currencies Service
- Complete currency information and codes
- Real-time currency conversion with external API integration
- Memory caching for exchange rates
- Support for all major world currencies

### Phone Numbering Plans Service
- Phone number validation by country
- Automatic formatting and normalization
- Mobile vs landline detection
- Area code validation
- International dialing code support

## Package

### SimplyWorks.I18n.Service
Core service components containing the business logic and data access layer.

**Key Models:**
- `Country` - Complete country information
- `Currency` - Currency data and codes
- `Pnp` (Phone Numbering Plan) - Phone validation rules
- `PnpResult` - Phone validation results
- `CurrencyRates` - Exchange rate data

**Key Services:**
- `CountriesService` - Country data retrieval and lookup
- `CurrenciesService` - Currency operations and conversion
- `PhoneNumberingPlansService` - Phone number validation
- `ExternalCurrencyRatesService` - Live exchange rate fetching

## Installation

```bash
dotnet add package SimplyWorks.I18n.Service
```

## Quick Start

```csharp
// Get country information
var countriesService = new CountriesService();
var country = countriesService.Get("US");
Console.WriteLine($"{country.Name} - {country.CurrencyCode}");

// Validate phone number
var phoneService = new PhoneNumberingPlansService(countriesService);
var result = phoneService.Validate("+1234567890", "US");
if (result.Status == PnpResultStatus.Ok)
{
    Console.WriteLine($"Valid {result.PhoneType} phone number");
}

// Convert currency
var currenciesService = new CurrenciesService(/* dependencies */);
var converted = await currenciesService.ConvertAsync(100m, "USD", "EUR");
```

## Data Sources

The library includes embedded binary data files containing:
- `country.bin` - Country information database
- `cntryd.bin` - Country lookup data
- `pnpd.bin` - Phone numbering plan database

## Requirements

- .NET Standard 2.1
- Entity Framework Core (for service package)
- Memory caching support

## License

This project is licensed under the [MIT License](LICENSE).

---

## NuGet Package Description

### For SimplyWorks.I18n.Service  
Comprehensive .NET internationalization services for country data lookup, real-time currency conversion, and phone number validation. Includes embedded databases for countries, currencies, and phone numbering plans with memory caching support. Provides country information with ISO codes, currency conversion with live exchange rates, and phone number validation with mobile/landline detection. For full documentation and examples, visit: https://github.com/simplify9/SW-I18nServices