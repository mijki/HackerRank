using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

int matrixSize = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

List<List<int>> arr = new List<List<int>>();

int primDiag = 0, secDiag = 0, i = 0, dif = 0;
int size = arr.Count;
int j = size - 1;

while (i < arr.Count)
{
    primDiag += arr[i][i];
    secDiag += arr[i][j];
    i++;
    j--;
}

dif = primDiag - secDiag;
if (dif < 0) dif = dif * -1;
return dif;