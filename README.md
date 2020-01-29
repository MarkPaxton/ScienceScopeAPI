# ScienceScopeAPI
Implementation of ScienceScope Logbook protocol in C# for .NET 3.5 Desktop and Compact frameworks

This is a library to interface with ScienceScope data loggers over Bluetooth serial connection.

https://sciencescope.uk/product/logbook-ml/

The bluetooth implementation with the logbook is a propriatary serial protocol, and provides simple data readout as well as an extended high definition binary readout that us post-processed on the desktop platform.

The connection can be quite unstable due to the specifics of the Bluetooth stack used on both the device as well as the client, thus attention had to be on monitoiring and recovering the connection.
