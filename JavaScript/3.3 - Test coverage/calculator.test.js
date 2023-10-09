const chai = require("chai");
const should = chai.should();
const Calculator = require(`./Calculator`);

describe(`Calculator Tests`, () => {
  describe(`Divide Tests`, () => {
    it(`should divide a given number by another given number and produce the correct result`, () => {
      const calculator = new Calculator();
      const expected = 5;
      const actual = calculator.divide("10,2");
      actual.should.be.eql(expected);
    });

    it(`should return an error when one argument in the string is not a number`, () => {
      const calculator = new Calculator();
      const expected = `Invalid numbers supplied`;
      const actual = calculator.divide("10,bob");
      (actual.message).should.be.eql(expected);
    });

    it(`should divide correctly when one argument is a negative number`, () => {
      const calculator = new Calculator();
      const expected = -5;
      const actual = calculator.divide("10,-2");
      actual.should.be.eql(expected);
    });

    it(`should return an error when dividing by zero`, () => {
      const calculator = new Calculator();
      const expected =
        `0 supplied as the divisor - unable to complete calculation`;
      const actual = calculator.divide("10,0");
      (actual.message).should.be.eql(expected);
    });
  });

  describe(`Multiply Tests`, () => {
    it(`Should multiply a given number by another and produce the correct result`, () => {
      const calculator = new Calculator();
      const expected = 12;
      const actual = calculator.multiply("6,2");
      actual.should.be.eql(expected);
    });

    it(`Should return an error when one argument in the string isn't a number`, () => {
      const calculator = new Calculator();
      const expected = `Invalid numbers supplied`;
      const actual = calculator.multiply("6,tom");
      (actual.message).should.be.eql(expected);
    });

    it(`Should correctly multiply a negative number`, () => {
      const calculator = new Calculator();
      const expected = -12;
      const actual = calculator.multiply("-2,6");
      actual.should.be.eql(expected);
    });
  });

  describe(`Subtract Tests`, () => {
    it(`should subtract a given number by another given number and produce the correct result`, () => {
      const calculator = new Calculator();
      const expected = -5;
      const actual = calculator.subtract("5,10");
      actual.should.be.eql(expected);
    });

    it(`should return an error when one argument in the string is not a number`, () => {
      const calculator = new Calculator();
      const expected = `Invalid numbers supplied`;
      const actual = calculator.subtract("10,bob");
      (actual.message).should.be.eql(expected);
    });

    it(`should subtract correctly when one argument is a negative number`, () => {
      const calculator = new Calculator();
      const expected = 12;
      const actual = calculator.subtract("10,-2");
      actual.should.be.eql(expected);
    });

    it(`should subtract correctly when one argument is a negative number`, () => {
      const calculator = new Calculator();
      const expected = 8;
      const actual = calculator.subtract("10.5,2.5");
      actual.should.be.eql(expected);
    });
  });
});
