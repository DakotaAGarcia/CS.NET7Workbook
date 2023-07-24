int thisCannotBeNull = 4;
//thisCannotBeNull = null;
WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

Address address = new()
{
	Building = null,
	Street = null!,
	City = "SLC",
	Region = "US"
};

//WriteLine(address.Building.Length);
WriteLine(address.Street.Length);

WriteLine(address.Building?.Length);