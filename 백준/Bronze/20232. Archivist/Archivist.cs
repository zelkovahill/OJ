var input = int.Parse(Console.ReadLine()!);


if (input == 1995 || input == 1998 || input == 1999 || input == 2001 || input == 2002 || input == 2003 || input == 2004 || input == 2005 || input == 2009
    || input == 2010 || input == 2011 || input == 2012 || input == 2014 || input == 2015 || input == 2016 || input == 2017 || input == 2019)
    Console.WriteLine("ITMO");

else if (input == 1996 || input == 1997 || input == 2000 || input == 2007 || input == 2008 || input == 2013 || input == 2018)
    Console.WriteLine("SPbSU");


else if (input == 2006) Console.WriteLine("PetrSU, ITMO");