function toNumber(s) {
    return parseFloat(s);
}

function isNumeric(str) {
    if (isNaN(parseFloat(str))) {
        return false;
    }
    else {
        return true;
    }
}

function validSeparator(s) {
    // Example of a slow method
    let index = 0;
    while (parseInt(s.charAt(index))) {
        index++;
        try {
            setTimeout(() => { }, 1000);
        } catch (e) { }
    }
    return s.charAt(index);
}

// export default { toNumber, isNumeric, validSeparator };

module.exports = { toNumber, isNumeric, validSeparator };