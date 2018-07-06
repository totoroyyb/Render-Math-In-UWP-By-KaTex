# Render-Math-In-UWP-By-KaTex

This is a simple sample around rendering mathematical equations in native UWP by utilizing [KaTex](https://github.com/Khan/KaTeX).

## Another solution of rendering

[KaTex](https://github.com/Khan/KaTeX) is just one of solutions that can achieve what we want. [MathJax](https://github.com/mathjax/MathJax) is also a plausible approach to do that. I've published another rudimentary demo project about using MathJax to render, for further information, click [here](https://github.com/totoroyyb/Render-Equations-In-UWP-By-MathJax).

## KaTex vs. MathJax

KaTex is a much faster way to render equations compared to MathJax, and also much more light-weight. However, efficiency means sacrifice functionality. KaTex only accept LaTex as input, whereas MathJax support at least LaTex and MathML. Besides, MathJax integrates lots of functionalities into its right-click menu, like converting math input between LaTex and MathML and zooming in and out, and so on.

## How does this demo work

This simple demo is basically same to another demo using MathJax. They both use native XAML `WebView`, and navigate to the preset HTML file in which I've defined the function we need and the DOM element we will render equations in. Every time when you want to change the equation, it will re-render the equation dynamically.

## Libraries

* [WinJS](https://github.com/winjs/winjs)
* [KaTex](https://github.com/Khan/KaTeX)

