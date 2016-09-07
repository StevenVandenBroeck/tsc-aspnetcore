import { Greeting } from 'Greeting';

class Greeter {

    greeting: Greeting;

    constructor(greeting: Greeting) {
        this.greeting = greeting;
    }

    say(text: string) {
        var message = text + ' ' + this.greeting.getHello();
        console.log(message);
        document.getElementById('typescript-container').innerHTML = message;
    }

};

export function start() {
    var greeting = new Greeting();
    var greeter = new Greeter(greeting);
    greeter.say('Hello');
}
