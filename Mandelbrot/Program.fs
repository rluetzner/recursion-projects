open System
open System.Windows.Forms
open System.Drawing
 
[<EntryPoint>]
[<STAThread>]
let main argv = 
 
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault false
 
    use form = new Form()
    let g = form.CreateGraphics()
    let p = new Pen(Color.FromArgb(255, 0, 0, 0))
    let p1 = new Point(50,50)
    let p2 = new Point(100,-100)
    g.DrawLine(p, p1, p2)
    form.Refresh()
    Application.Run(form);
 
    0 