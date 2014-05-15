# Xpath expression with unmatched parentheses/brackets crash generator.exe

## Problem

Xpath expression with unmatched parentheses/brackets like

	path="/api/package[[@name='com.samsung.sdk']"
	path="/api/package[[@name='com.samsung.sdk']]"

results:

*	crashes generator.exe in Visual Studio 2012
*	3 errors in Xamarin Studio, but no crash

## Cause

## Workaround 

## Details

### Xamarin Studio errors

	MonoDroid.Generation.BindingGeneratorException: 
	Error BG4301: Invalid XPath specification: /api/package[[@name='com.samsung.sdk'] (BG4301) (BindingLibrary1)

	Error BG4301: Invalid XPath specification: /api/package[[@name='com.samsung.sdk'] (BG4301) (BindingLibrary1)

	[ERROR] FATAL UNHANDLED EXCEPTION: MonoDroid.Generation.BindingGeneratorException: 
	Error BG4301: Invalid XPath specification: /api/package[[@name='com.samsung.sdk'] 