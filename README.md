# FarmForge
FarmForge is an open source project for building out an IoT enhanced farm or garden. The Api can be run locally on either a computer or a Raspberry Pi.

## Project Structure
FarmForge contains the following Directories / Projects
1. [FarmForge.Api](https://github.com/StrykerDG/FarmForge/tree/master/FarmForge.Api) - The Api related projects that handle application requests

    - [FarmForge.Api](https://github.com/StrykerDG/FarmForge/tree/master/FarmForge.Api/FarmForge.Api) - The Actual API

    - [FarmForge.DataModel](https://github.com/StrykerDG/FarmForge/tree/master/FarmForge.Api/FarmForge.DataModel) - The project that contains all of the database models

    - [FarmForge.Migrations](https://github.com/StrykerDG/FarmForge/tree/master/FarmForge.Api/FarmForge.Migrations) - The project that contains database migrations

2. [FarmForge.Client]() - The user facing application

    - [farm_forge_client]() - The actual Flutter application

3. [FarmForge.Devices]() - A collection of different devices that have been setup to work with FarmForge