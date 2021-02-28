<p align="center"">
    <h1 align="center">Mandelsharp</h1>
    <p align="center">
        <img src="https://img.shields.io/badge/made%20with-C%23-blue?style=plastic">
        <img src="https://img.shields.io/badge/license-MIT-green?style=plastic">
        <img src="https://img.shields.io/badge/open%20source-red?style=plastic">
        <img src="https://img.shields.io/badge/suggestions-welcome-green?style=plastic">
        <img src="https://img.shields.io/github/last-commit/augus99/mandelsharp?style=plastic">
        <img src="https://img.shields.io/github/commit-activity/y/augus99/mandelsharp?style=plastic">
    </p>
</p>

## Description
Basic command line interface (CLI) for rendering the mandelbrot fractal.

## Build
To build the project you will need `dotnet` installed on your computer, then type the following commands on your preferred terminal
```console
augus99@home:~/Desktop $ git clone https://github.com/augus99/mandelsharp.git
augus99@home:~/Desktop $ cd mandelsharp
augus99@home:~/Desktop/mandelsharp $ dotnet build
```

## Run
To run this project simply run this command
```console
augus99@home:~/Desktop/mandelsharp $ dotnet run
```

## Options
This application provides 6 optionals arguments

| Option           | Description                 | Default Value |
| ---------------- | --------------------------- | --------- |
| <kbd>-s</kbd> <kbd>--size</kbd> | Set result image width and height.       | `512` |
| <kbd>-o</kbd> <kbd>--output</kbd> | Set result image output path.       | `./mandelbrot.png` |
| <kbd>-x</kbd> <kbd>--xcoord</kbd> | Set x coordinate to zoom in.       | `-1` |
| <kbd>-y</kbd> <kbd>--ycoord</kbd> | Set y coordinate to zoom in.       | `-1` |
| <kbd>-z</kbd> <kbd>--zoom</kbd> | Set zoom value.       | `-1` |
| <kbd>-c</kbd> <kbd>--czoom</kbd> | Set cartasian zoom value.       | `-1` |

## Examples

```console
augus99@home:~/Desktop/mandelsharp $ dotnet run --size 512 -x -88 -y 0 --czoom 5
augus99@home:~/Desktop/mandelsharp $ dotnet run --size 128
```
