# Whips-Image-Converter
##Where do I get the program?
Option 1: Download Whips-Image-Converter/Release.exe

Option 2: Navigate to Whips-Image-Converter/WindowsForms2/bin/debug and download the debug folder

Option 3: Download all the source files and complie the project in Visual Studio

## Intro
This is an image converter that I created to convert images for Space Engineers.

If you modify this, please credit me :) 

This is my first windows app, and I spent a lot of time on this. I hope y'all enjoy!

##Description
This code utilizes a variety of dithering methods to convert each pixel from  a 256x256x256 color into a 8x8x8 color.
By reducing the number of colors in an image, we can use the color pixels in the Monospace font in Space Engineers
to "draw" the image.

##How to use
1) Browse for your desired image file.

2) Select resizing option.

3) Select dithering option.

4) Click "Convert".

5) Copy and Paste all of the text in the "Converted String" output into your in-game LCD panel. Make the font size 0.1 and the 
   font MONOSPACED.
