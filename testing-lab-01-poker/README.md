# Blackjack Calculator TDD Exercise

## Learning Goals

* Practice writing tests using some testing library. Any will do.
* Practice ping-pong-style TDD

## Scenario

We are to write a Blackjack calculator, TDD-style. This calculator should simulate the process of counting the values of cards in a blackjack hand.

* Create a function/class for calculating a Blackjack hand. It should take an array of cards and return a calculated score for the cards. Other than that, take as much freedom as you want to choose what classes you want to create, datatypes to use...whatever.
* Do this using ping-pong style testing: Developer 1 writes the test and passes the keyboard, dev 2 writes the code to pass the test. Then 2 writes the next test, passes the keyboard and dev 1 writes the code.
* For the ace, always calculate as you would when you play, i.e., it is always 11 unless it would cause you to bust
* Come up with as many card scenarios as you can think of that would be useful. Here's some sample sets of cards for you to start with.
  - [7, 8]
  - [3, 5, 6]
  - [5, K]
  - [5, 7, J]
  - [A, K]
  - [4, K, A, A]
  - [A, A, 2, A, A]

## Pre-Built Scaffolds

There is a pre-built scaffold for doing this in JavaScript. See the `js` folder. You don't have to use any of the scaffolding. You can create your own and do this in any language and use any testing library you want.
