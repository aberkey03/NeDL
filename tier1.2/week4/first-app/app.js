/* 
const path = require('path');

var pathObj = path.parse(__filename);

console.log(pathObj);

const log = require('./logger'); //  'require'  pulls in the log method from the logger module

log('message');  */

const EventEmitter = require('events'); //create 'EventEmitter' class
//const emitter = new EventEmitter(); //create EventEmitter object called 'emitter'



const Logger = require('./logger');
const logger = new Logger();

// Register a listener
logger.on('messageLogged', (arg) => {      //e, evetnArg instead of arg    //  function(arg){ instead of 
    console.log('listener called', arg);
})

logger.log('message');