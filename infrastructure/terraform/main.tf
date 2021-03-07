# Configure the Azure provider
terraform {
  required_providers {
    azurerm = {
      source = "hashicorp/azurerm"
      version = ">= 2.26"
    }
  }

  backend "azurem" {
  }
}

provider "azurem" {
  features {}
}

resource "azurerm_resource_group" "test" {
  name     = "wedding-eu-test-rg"
  location = "westeurope"
}

resource "azurerm_app_service_plan" "test" {
  name                = "wedding-web-test-asp"
  location            = azurerm_resource_group.example.location
  resource_group_name = azurerm_resource_group.example.name

  sku {
    tier = "Free"
    size = "F1"
  }
}

resource "azurerm_app_service" "test" {
  name                = "example-app-service"
  location            = azurerm_resource_group.example.location
  resource_group_name = azurerm_resource_group.example.name
  app_service_plan_id = azurerm_app_service_plan.example.id

  app_settings = {
    "ASPNETCORE_ENVIRONMENT" = "Test"
  }
}