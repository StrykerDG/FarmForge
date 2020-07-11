# FarmForge
FarmForge is an open source project for building out an IoT enhanced farm or garden. The Api can be run locally on either a computer or a Raspberry Pi.

## Project Structure
FarmForge contains the following Directories / Projects
1. [FarmForge.Api]() - The Api project that handles application requests

    - [FarmForge.Api]() - The Actual API

    - [FarmForge.DataModel]() - The project that contains all of the database models

    - [FarmForge.Migrations]() - The project that contains database migrations

2. [FarmForge.Client]() - The user facing application

    - [farm_forge_client]() - The actual Flutter application

3. [FarmForge.Devices]() - A collection of different devices that have been setup to work with FarmForge