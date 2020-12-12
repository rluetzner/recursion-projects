# Recursion Projects

## Mandelbrot GUI

This is a simple WinForms project that can draw different 2-dimensional fractals.

The fractals can be selected by switching to different tabs. Currently only Koch
curves and different variations of these are drawable.

### Shapes

#### Koch

I probably went a bit overboard with all the Koch shapes. I liked the Koch
Snowflake when I saw it on Wikipedia and it was really easy and tempting to add
a bunch more.

My initial attempt was to recreate an exercise I had to do for
university ages ago. This turned out to be pretty easy with the better
understanding for recursion that I have now.

### About the code

#### Recursion

Recursion is implemented via F#. F# supports tail recursion which would prevent
any stack overflow, but the level of recursion turned out to be so low that I
could have done this with C# as well.

It was still a good exercise in F#. ;-)

#### WinForms

The actual GUI part is implemented in C# for the sole reason that creating and
managing WinForms is waaaaaaaaaaaaay easier in C# than it is in F#. This is of
course a subjective opinion. As I was not interested in learning GUI programming
with F# and wanted to focus more on the recursion aspect using C# just seemed
more painless.

#### Building

Use `dotnet` to build:

```powershell
dotnet publish -c Release -o ./bin
```

## Towers of Hanoi

Towers of Hanoi is of course another classic programming exercise. This was again
prompted by a desire to redo one of the exercises (I probably failed at) when I
was still at university.

What brought me back around were these two YouTube videos I watched:

1. [5 Simple Steps for Solving Any Recursive Problem](https://www.youtube.com/watch?v=ngCos392W4w)
2. [Towers of Hanoi: A Complete Recursive Visualization](https://www.youtube.com/watch?v=rf6uf3jNjbo)

To be honest I was a bit embarassed when I realized that I did not understand this
as a student, because after a few minutes of watching the Towers of Hanoi video I
paused it and quickly implemented this solution in F#.

This takes a number from Stdin, but has only very basic validation so inputing
anything else than a number will make this crash.

### About the code

As mentioned above I quickly thought of F# as it has tail recursion. Here it is
actually useful (I think). You can give an unnecessarily high number of rings
and it will print out the instructions to solve this. I was however

1. too lazy to wait around for hours until it had solved 296 rings and
2. wouldn't have verified the solution anyway.

### Building

Use `dotnet` to build:

```powershell
dotnet publish .\TowersOfHanoi\TowersOfHanoi.fsproj -c Release -o ./bin
```