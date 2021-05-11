# Team-Neptune
Group Project

1) create a  class called Holiday. An object of class Holidayrepresents a holiday during the year. This class has three instance variables:
● name, which is a String representing the name of the holiday
● day, which is an int representing the day of the month of the holiday
● month, which is a String representing the month the holiday is in

a) Write a constructor for the class Holiday, which takes a String representing the name, an
int representing the day, and a String representing the month as its arguments, and sets the
class variables to these values.

b) Write a method inSameMonth, which compares two instances of the class Holiday,and
returns the Boolean value true if they have the same month, and false if they do not.

c) Write a method avgDatewhich takes an array of base type Holiday as its argument, and
returns a double that is the average of the day variables in the Holiday instances in the
array. You may assume that the array is full (i.e. does not have any null entries).

d) Write a piece of code that creates a Holiday instance with the name “Independence Day”,
with the day “1”, and with the month “October”.

2) Create a  class Movie. An instance of class Movie represents a film. This class has the following three class variables:
● title, which is a String representing the title of the movie
● studio, which is a String representing the studio that made the movie
● rating, which is a String representing the rating of the movie (i.e. PG13, R, etc)

a) Write a constructor for the class Movie, which takes a String representing the title of the
movie, a String representing the studio, and a String representing the rating as its
arguments, and sets the respective class variables to these values.

b) Write a second constructor for the class Movie, which takes a String representing the title
of the movie and a String representing the studio as its arguments, and sets the respective
class variables to these values, while the class variable rating is set to "PG".

c) Write a method getPG, which takes an array of base type Movie as its argument, and
returns a new array of only those movies in the input array with a rating of "PG". You may
assume the input array is full of Movie instances. The returned array need not be full.

d) Write a piece of code that creates an instance of the class Movie with the title “Casino
Royale”, the studio “Eon Productions”, and the rating “PG13