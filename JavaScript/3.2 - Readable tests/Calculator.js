// @ts-nocheck
let utils = require(`./utils`);

class Calculator {
  constructor() {}

  divide(n1) {
    let result = -9999;
    let separator = `,`;
    // if doesn't contain a comma call this
    if (!n1.includes(`,`)) {
      // separator is replaced with the result of the validSeparator call when passing n1
      separator = utils.validSeparator(n1); // slows down test
    }
    let numbers = n1.split(separator);

    for (let number of numbers) {
      if (!utils.isNumeric(number)) {
        return new Error(`Invalid numbers supplied`);
      }
    }

    if (numbers[1] == 0) {
      return new Error(
        `0 supplied as the divisor - unable to complete calculation`,
      );
    }

    result = utils.toNumber(numbers[0]) / utils.toNumber(numbers[1]);
    return result;
  }

  multiply(n1) {
    let result = -9999;
    let seperator = `,`;
    if (!n1.includes(`,`)) {
      // Seperator is replaced with the result of the validSeperaor call when passing N1
      seperator = utils.validSeparator(n1);
    }
    let numbers = n1.split(seperator);

    for (let number of numbers) {
      if (!utils.isNumeric(number)) {
        return new Error(`Invalid numbers supplied`);
      }
    }
    result = utils.toNumber(numbers[0]) * utils.toNumber(numbers[1]);
    return result;
  }

  subtract(n1) {
    let result = -9999;
    let separator = `,`;
    // if doesn't contain a comma call this
    if (!n1.includes(`,`)) {
      // separator is replaced with the result of the validSeparator call when passing n1
      separator = utils.validSeparator(n1); // slows down test
    }
    let numbers = n1.split(separator);
    for (let number of numbers) {
      if (!utils.isNumeric(number)) {
        return new Error(`Invalid numbers supplied`);
      }
    }

    result = utils.toNumber(numbers[0]) - utils.toNumber(numbers[1]);
    return result;
  }
}
module.exports = Calculator;
