﻿
using ListFiltering;

//In this kata you will create a function that takes a list of non-negative integers 
//and strings and returns a new list with the strings filtered out.

//ex is in the below

//ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }) => { 1, 2}
//ListFilterer.GetIntegersFromList(new List<object>() { 1, "a", "b", 0, 15 }) => { 1, 0, 15}
//ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 123 }) => { 1, 2, 231}


var list1 = new List<object>() { 1, 2, "a", "b" };
var list2 = new List<object>() { 1, "a", "b", 0, 15 };
var list3 = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 123 };

foreach (var item in ListFilterer.GetIntegersFromList(list2))
{
    Console.WriteLine(item);
}

