//initialize count variables to be incremented
let sweetCount = 0;
let saltyCount = 0;
let sweetAndSaltyCount = 0;
//initialize empty string to concat to
let str = "";

//for loop to loop through range and output sweet/salty/sweet and salty
for (let i = 1; i <= 1000; i++) {
    //if the number is a multiple of 3 and 5, concat sweet'nsalty with space and increase sweetandsaltycount
    if (i % 3 === 0 && i % 5 === 0) {
        str += "Sweet'nSalty ";
        sweetAndSaltyCount++;
    //if the number is a multiple of 3, concat sweet with space and increase sweetcount
    } else if (i % 3 === 0) {
        str += "Sweet ";
        sweetCount++;
    //if the number is a multiple of 5, concat salty with space and increase saltycount
    } else if (i % 5 === 0) {
        str += "Salty ";
        saltyCount++;
    //if the number is not a multiple of 5 or 3, concat the number with space
    } else {
        str += `${i} `;
    }
    //print 20 numbers/words per line
    if (i % 20 === 0) {
        //print the entire concatenated string
        console.log(str);
        //reset the string variable
        str = "";
    }
}

//print out how many sweet, salty, sweet'nsalty
console.log(`Sweet: ${sweetCount}`);
console.log(`Salty: ${saltyCount}`);
console.log(`Sweet'nSalty: ${sweetAndSaltyCount}`);   