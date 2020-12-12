namespace Mandelbrot.Core

open System.Drawing
open System

module Koch =

    let getLength l hyp angle angleFunc =
        let xFloat = l |> float
        let hypFloat = hyp |> float
        let angleFloat = angle |> float
        let radians = Math.PI * angleFloat / 180.
        xFloat + hypFloat * angleFunc(radians)
        |> Math.Round
        |> int

    let xLength x hyp angle =
        getLength x hyp angle Math.Cos

    let yLength y hyp angle =
        getLength y hyp angle Math.Sin        

    let rec draw order angle customLength paintFunc (start : Point) =
        if order = 0 then            
            let finish = new Point((xLength start.X customLength angle), (yLength start.Y customLength angle))
            paintFunc start finish
            finish
        else
            let newLength = customLength / 3
            draw (order - 1) angle newLength paintFunc start
            |> draw (order - 1) (angle-60) newLength paintFunc
            |> draw (order - 1) (angle+60) newLength paintFunc
            |> draw (order - 1) angle newLength paintFunc


    let Draw order (start:Point) length (paintFunc : System.Action<Point,Point>) =
        draw order 0 length (fun x y -> paintFunc.Invoke(x,y)) start

    let DrawSnowflake order (start:Point) length (paintFunc : System.Action<Point,Point>) =
        draw order -60 length (fun x y -> paintFunc.Invoke(x,y)) start
        |> draw order 60 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 180 length (fun x y -> paintFunc.Invoke(x,y))

    let DrawHexagon order (start:Point) length (paintFunc : System.Action<Point,Point>) =
        draw order -60 length (fun x y -> paintFunc.Invoke(x,y)) start
        |> draw order 0 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 60 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 120 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 180 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 240 length (fun x y -> paintFunc.Invoke(x,y))

    let DrawSquare order (start:Point) length (paintFunc : System.Action<Point,Point>) =
        draw order -90 length (fun x y -> paintFunc.Invoke(x,y)) start
        |> draw order 0 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 90 length (fun x y -> paintFunc.Invoke(x,y))
        |> draw order 180 length (fun x y -> paintFunc.Invoke(x,y))