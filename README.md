# Whips-Image-Converter
## Where do I get the program?
* Option 1: Download the program [HERE](https://github.com/Whiplash141/Whips-Image-Converter/raw/master/WhipsImageConverter/bin/Debug/Whip%60s%20Image%20Converter.exe)

* Option 2: Navigate to Whips-Image-Converter/WhipsImageConverter/bin/debug and download the debug folder

* Option 3: Download all the source files and complie the project in Visual Studio

## Intro
This is an image converter that I created to convert images for Space Engineers.

If you modify this, please credit me :) 

This is my first windows app, and I spent a lot of time on this. I hope y'all enjoy!

## Interface
![Interface](https://i.gyazo.com/8c664b8051748f80443fdbfaa3527a12.png)

##Description
This code utilizes a variety of dithering methods to convert each pixel from  a 24 bit color into a 9 bit color.
By reducing the number of colors in an image, we can use the color pixels in the Monospace font in Space Engineers
to "draw" the image on a text panel without the need for mods.

## How to use
1. Browse for your desired image file.

2. Select resizing option.

3. Select dithering option.

4. Click "Convert".

5. Copy and Paste all of the text in the "Converted String" output into your in-game LCD panel. Make the font size 0.1 and the 
   font MONOSPACED.
