# TinyAlert

TinyAlert is a quick and easy to use notification pop-up for C# Windows Form Applications. It includes a static class where you can call TinyAlertView.Show() anywhere you like.

It automatically moves and resizes with your form, and expands to match the text size. It fades in and then fades out, depending on how long you set it.

![ScreenShot](http://www.a-iats.com/App/TA1.png)

## Usage

1. Drag TinyAlert.cs, TinyAlertDesigner.cs and TinyAlert.resx into your document
2. Drag CustomMessageBox into your document
3. Change the namespace of both files to match your project
4. Set it up as follows (Similar to example code)

``` 
//Pass your Form inside and set the fade timing
private void Form1_Load(object sender, EventArgs e)
{
	TinyAlertView.SetUI(this);
	TinyAlertView.SetTiming(5);
}

//Set Event handler for Form Movements
private void UI_Move(object sender, EventArgs e)
{
	TinyAlertView.SetLocation();
}

//Set Event handler for Form Resize
private void UI_Resize(object sender, EventArgs e)
{
	TinyAlertView.SetLocation();
}

//Call TinyAlert
private void button1_Click(object sender, EventArgs e)
{
	TinyAlertView.Show(TinyAlertView.StateTinyAlert.SUCCESS, "A");
}

```

## Functions

TinyAlert contains several functions that let you change the Font and Color. However, they have been encompassed into three states in the static class. They are SUCCESS,WARNING and FAILURE. You can simply add more states to including more variety.

LICENSE
-------

Copyright (C) 2012 by Raaj

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.