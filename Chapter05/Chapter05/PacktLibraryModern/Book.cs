﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Book
{
	public Book() { }
	[SetsRequiredMembers]
	public Book(string? isbn, string? title)
	{
		Isbn = isbn;
		Title = title;
	}
	public required string? Isbn { get; set; }
	public required string? Title { get; set; }
	public string? Author { get; set; }
	public int PageCount { get; set; }
}
