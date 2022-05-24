// Put your code here

const DisplaySpellBook = (book) => {
  //   console.log(book.title);
  book.forEach((spell) => console.log(spell.name));
  //   for (aSpell in book) {
  //     console.log(`  ${aSpell.name}`);
  //   }
};

const makeEvilSpellBook = (allSpells) => {
  //   const evilBook = { title: "", spells: [] };
  let evilBook = allSpells;
  //   evilBook.title = "Evil Book";
  evilBook = allSpells.filter((spell) => spell.isEvil);

  return evilBook;
};

const makeGoodSpellBook = (allSpells) => {
  let goodBook = allSpells;
  //   const goodBook = { title: "", spells: [] };
  //   goodBook.title = "Good Book";
  goodBook = allSpells.filter((spell) => !spell.isEvil);

  return goodBook;
};

const getAllSpells = () => {
  const allSpells = [
    {
      name: "Turn enemy into a newt",
      isEvil: true,
      energyReqired: 5.1,
    },
    {
      name: "Conjure some gold for a local charity",
      isEvil: false,
      energyReqired: 2.99,
    },
    {
      name: "Give a deaf person the ability to heal",
      isEvil: false,
      energyReqired: 12.2,
    },
    {
      name: "Make yourself emperor of the universe",
      isEvil: true,
      energyReqired: 100.0,
    },
    {
      name: "Convince your relatives your political views are correct",
      isEvil: false,
      energyReqired: 2921.5,
    },
  ];

  return allSpells;
};

console.log("Do you believe in magic?");
console.log("------------------------");

const allSpells = getAllSpells();
const goodBook = makeGoodSpellBook(allSpells);
const evilBook = makeEvilSpellBook(allSpells);

console.log("Good Book");
DisplaySpellBook(goodBook);
console.log();
console.log("Evil Book");
DisplaySpellBook(evilBook);
