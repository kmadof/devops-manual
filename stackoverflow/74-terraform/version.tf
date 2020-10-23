terraform {
  required_version = ">=0.13"

 backend "azurerm" {
   container_name = "tfstate"
   key            = "terraform.tfstate"
 }

 required_providers {
   grafana = {
   source  = "grafana/grafana"
   version = "=1.5.0"
   }
  }
}