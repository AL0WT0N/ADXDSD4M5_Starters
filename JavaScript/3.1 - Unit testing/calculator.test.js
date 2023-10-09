const chai = require('chai');
const expect = chai.expect;
const Calculator = require('./Calculator');

describe('Calculator.multiply()', function () {
    it('calculates result when numbers are valid', function () {
        const calc = new Calculator();
        const result = calc.multiply("10,22");
        expect(result).to.be.equal(220);
    });
});