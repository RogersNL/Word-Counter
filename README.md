# _Word Counter_

#### _An app that counts the number of instances of a word in a string, June 29, 2018_

#### By _**Nick Rogers**_

## Description

_This app was created to count the number of instances of a word in a string.
Specs:
1. Program will accept a valid user inputted word that will be used to be checked for in a string.
  Example input: "the"
  Example output: userInput = "the" -valid-
  Example reasoning: "the" is a commonly used word and often shows up partially in other words.

2. Program will accept a user inputted list of words as one input that will be split into an array.
  Example input: "The last theme for the Wednesday talk was Pokemon."
  Example output: {"The", "last", "theme", "for", "the", "Wednesday", "talk", "was", "Pokemon."}
  Example reasoning: This sentence includes upper and lower case and a partial match to the word "the".

3. Program will remove punctuation, force to lower case, and sort the array.
  Example input: {"The", "last", "theme", "for", "the", "Wednesday", "talk", "was", "Pokemon."}
  Example output: {"for", "last", "pokemon", "talk", "the", "the", "theme",  "was", "wednesday"}
  Example reasoning: Example shows removing puctuation, forcing to lower case, and sorting.

4. Program will check each word in the array with the first word inputted. Partial matches not counted.
  Example input: compare "the" with {"for", "last", "pokemon", "talk", "the", "the", "theme",  "was", "wednesday"}
  Example output: 2 matches
  Example reasoning: Example shows that two instances of "the" were found and "theme" was not included in the count.
_

## Setup/Installation Requirements

* _Clone repository from github_
* _Compile and mono program from console._

## Known Bugs

_No known bugs._

## Support and contact details

_Nick Rogers email: amellocello@msn.com_

## Technologies Used

_Created with Atom editor.  Use mono console to view._

### License

*No license required*

Copyright (c) 2018 **_Nick Rogers_**
