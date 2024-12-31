# Uninitialized Property Access in C#

This repository demonstrates a potential issue in C# related to accessing class properties before they've been explicitly initialized.  Uninitialized properties can lead to unexpected behavior, making it a subtle and sometimes hard-to-debug error.

## The Problem

In C#, if you access a class property without first assigning a value to it, the property's default value will be used.  This default value is 0 for numeric types, null for reference types, and false for booleans.  This can lead to incorrect calculations, null reference exceptions, or other issues if you are not anticipating this default behavior.

## The Solution

Always initialize properties to a safe default value in the class constructor, or explicitly assign a value to the property before accessing it.