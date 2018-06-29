# _Word Counter_

#### _An app that counts the number of instances of a word in a string, June 29, 2018_

#### By _**Nick Rogers**_

## Description

_This app was created to count the number of instances of a word in a string._
_Specs:_
_1. Program will accept a valid user inputted word that will be used to be checked for in a string._
  _Example input: "the"_
  _Example output: userInput = "the" -valid-_
  _Example reasoning: "the" is a commonly used word and often shows up partially in other words._

_2. Program will accept a user inputted list of words as one input that will be split into an array._
  _Example input: "The last theme for the Wednesday talk was Pokemon."_
  _Example output: {"The", "last", "theme", "for", "the", "Wednesday", "talk", "was", "Pokemon."}_
  _Example reasoning: This sentence includes upper and lower case and a partial match to the word "the"._

_3. Program will remove punctuation, force to lower case, and sort the array._
  _Example input: {"The", "last", "theme", "for", "the", "Wednesday", "talk", "was", "Pokemon."}_
  _Example output: {"for", "last", "pokemon", "talk", "the", "the", "theme",  "was", "wednesday"}_
  _Example reasoning: Example shows removing puctuation, forcing to lower case, and sorting._

_4. Program will check each word in the array with the first word inputted. Partial matches not counted._
  _Example input: compare "the" with {"for", "last", "pokemon", "talk", "the", "the", "theme",  "was", "wednesday"}_
  _Example output: 2 matches_
  _Example reasoning: Example shows that two instances of "the" were found and "theme" was not included in the count._

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
