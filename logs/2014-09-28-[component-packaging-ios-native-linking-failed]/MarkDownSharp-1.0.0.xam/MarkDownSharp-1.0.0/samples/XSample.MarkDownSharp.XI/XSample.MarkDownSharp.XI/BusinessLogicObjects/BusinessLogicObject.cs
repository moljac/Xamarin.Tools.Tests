using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XSample.MarkDownSharp
{
	public partial class BusinessLogicObject 
	{
		public static MarkdownSharp.Markdown MarkDownEngine = null;

		public static string MarkUpHTML = "";
		public static string MarkDown = 
@"
## Welcome to MarkDownSharp

This demo page lets you try MonoMobile version of MarkDownSharp in your browser.


*italic*   **bold**
_italic_   __bold__


[HolisticWare site](http://holisticware.net/ ""HolisticWare"")



![HolisticWare logo](http://holisticware.net/Frontend/Images/logo.png ""Title"")



![HolisticWare logo][id]

[id]: http://holisticware.net/Frontend/Images/logo.png ""HolisticWare logo""



Header 1
========


Header 2
--------



# Header 1 #

## Header 2 ##

###### Header 6



1.  Foo
2.  Bar


*   A list item.

	With multiple paragraphs.

*   Bar




*   Abacus
	* answer
*   Bubbles
	1.  bunk
	2.  bupkis
		* BELITTLER
	3. burper
*   Cunning


> Email-style angle brackets
> are used for blockquotes.

> > And, they can be nested.

> #### Headers in blockquotes
> 
> * You can quote a list.
> * Etc.


> Email-style angle brackets
> are used for blockquotes.

> > And, they can be nested.

> #### Headers in blockquotes
> 
> * You can quote a list.
> * Etc.



This is a normal paragraph.

	This is a preformatted
	code block.


---

* * *

- - - - 




<div markdown=""1"">
Markdown **still** works.
</div>




~~~
This is a preformatted
code block
~~~


Fruit    |Color
---------|----------
Apples   |Red
Pears	 |Green
Bananas  |Yellow





Term 1
: Definition 1

Term 2
: Definition 2




Body text with a footnote [^1]

[^1]: Footnote text here



MDD <- will have title

*[MDD]: MarkDownSharp

";


		static BusinessLogicObject()
		{
			MarkDownEngine = new MarkdownSharp.Markdown();
		}
	}
}
