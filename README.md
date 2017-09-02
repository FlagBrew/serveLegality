serveLegality
=====
![License](https://img.shields.io/badge/License-GPLv3-blue.svg)

Pokémon legality checker server, meant to use with [PKSM](https://github.com/BernardoGiordano/PKSM). Heavily based on [PKHeX.Core](https://github.com/kwsch/PKHeX).

## Usage

This software is meant to be used in couple with PKSM.

To use this, you should follow those steps:

* Make sure the devices running PKSM and serveLegality are connected to the same network.
* Launch the wireless option in PKSM: `PKSM>Editor>Y`
* Note the `IPADDRESS` in the bottom screen
* Launch serveLegality from a CLI using `serveLegality IPADDRESS`
 * Optional: to get more detailed informations, run `serveLegality IPADDRESS verbose`
* In PKSM, move onto a pokemon in your boxes, then press `X` to enter serveLegality's IP address, then confirm
* Send any pokemon file you want by pressing `X` on PKSM, the legality report will appear on serveLegality

## Building

serveLegality/PKHeX.Core is a Windows CLI application which requires [.NET Framework v4.6](https://www.microsoft.com/en-us/download/details.aspx?id=48137).

The executable can be built with any compiler that supports C# 7.

### Credits

* Kaphotics and SciresM for PKHeX, on which this software is heavily based. Without their legality checking APIs, this couldn't exist anytime soon.
* ArchitDate, which provided his PKHeX [AutoLegality-mod](https://github.com/architdate/PKHeX-Auto-Legality-Mod/). Without his legality work, this couldn't exist anytime soon.