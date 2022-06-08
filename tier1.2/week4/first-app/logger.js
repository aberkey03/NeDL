//(function (exports, require, module, __filename, __dirname) {  // module wrapper function

const EventEmitter = require('events'); //create 'EventEmitter' class
//const emitter = new EventEmitter(); //create EventEmitter object called 'emitter'

/* console.log(__filename);
console.log(__dirname); */
var url = 'http://mylogger.io/log';

class Logger extends EventEmitter{

    log(message) {
        //send http request
        console.log(message);
    
        // Raise an event
        this.emit('messageLogged', { id: 1, url: 'http://example.com/message' });  
    }
}



// exporting allows the function to be public/loaded into other modules
// could also be done with the url, but keep this (or other variables) private 

module.exports = Logger;  

//module.exports.log = log;  // exports the whole object
//module.log = log;




