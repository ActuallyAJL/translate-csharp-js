// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const roll = () => {
  const dieValue = getRandomInt(1, 6);
  return { value: dieValue };
};

const getRandomInt = (min, max) => {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
};

const intToString = (int) => {
  let dieString = "";

  switch (int) {
    case 1:
      dieString = "one";
      break;
    case 2:
      dieString = "two";
      break;
    case 3:
      dieString = "three";
      break;
    case 4:
      dieString = "four";
      break;
    case 5:
      dieString = "five";
      break;
    case 6:
      dieString = "six";
      break;
  }

  return dieString;
};

for (let i = 0; i < 10; i++) {
  const die1 = roll();
  const die2 = roll();

  let message = `${intToString(die1.value)} + ${intToString(die2.value)} == ${
    die1.value + die2.value
  }`;
  if (die1.value == die2.value) {
    message += " DOUBLES!";
  }

  console.log(message);
}
