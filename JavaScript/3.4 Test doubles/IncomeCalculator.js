const Position = {
    NONE: 'NONE',
    BOSS: 'BOSS',
    PROGRAMMER: 'PROGRAMMER',
    SURFER: 'SURFER'
};

class ICalcMethod {
    calc() { }
}

class IncomeCalculator {
    constructor() {
        this.calcMethod = undefined;
        this.position = undefined;
    }

    setCalcMethod(calcMethod) {
        this.calcMethod = calcMethod;
    }

    setPosition(position) {
        this.position = position;
    }

    calc() {
        if (this.calcMethod == undefined) {
            throw new Error("Calc method not yet maintained");
        }

        if (this.position == undefined) {
            throw new Error("Position not yet maintained");
        }

        return this.calcMethod.calc(this.position);
    }
}

module.exports = {
    Position,
    ICalcMethod,
    IncomeCalculator,
};