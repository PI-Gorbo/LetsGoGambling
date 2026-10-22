type Fruit = 'Apple' | 'Orange'

interface InheritanceFruit {
    talkAbout(): string;
}
class InheritanceApple implements InheritanceFruit {
    talkAbout(): string {
        return "Apple";
    }
}
class InheritanceOrange implements InheritanceFruit {
    talkAbout(): string {
      return "Orange"
    }
}
class InheritancePineapple implements InheritanceFruit {
    talkAbout(): string {
        return "Pineapple"
    }
}

function talkAboutFruit(fruit: Fruit) {

    if (fruit === 'Apple') {
        console.log('Apple')
    } else if (fruit === 'Orange') {
        console.log('Orange')
    }

    throw Error("Combination not handled!")
}

function talkAboutInheritanceFruit(fruit: InheritanceFruit) {
   const message = fruit.talkAbout();
   console.log(message)
}