
const Joi = require('joi');
const express = require('express');

const req = require('express/lib/request');
const res = require('express/lib/response');

const app = express();  //app object

app.use(express.json());

/* app.get()
app.post()
app.put()
app.delete() */

const courses = [
    { id:1, name: 'course1' },
    { id:2, name: 'course2' },
    { id:3, name: 'course3' },
]

app.get('/', (req, res) => {
    res.send('Hello World!!!');
});

app.get('/api/courses', (req, res) => {
    res.send(courses);
});

app.post('/api/courses', (req, res) => {
    const { error } = validateCourse(req.body);
    if (error) {
        //400 Bad Request
        res.status(400).send(error.details[0].message);
        return;
    }

    const course = {
        id: courses.length + 1, 
        name: req.body.name
    };
    courses.push(course);
    res.send(course);
});

app.put('api/courses/:id', (req, res) =>{
    //loook up the course
    //if doesnt exist, return 404
    const course = courses.find(c => c.id === parseInt(req.params.id));
    if (!course) {
        return res.status(404).send('The course with the given id was not found.');
    }

    //validate
    // if invalid, return 400 -  Bad Request
    const schema = {
        name: Joi.string().min(3).required()
    };

    const { error } = validateCourse(req.body);
    if (error) {
        //400 Bad Request
        res.status(400).send(error.details[0].message);
        return;
    }

    //update course
    course.name = req.body.name;
    // return the updates course 
    res.send(course);
}); 

app.get('/api/courses/:id', (req, res) => {
    const course = courses.find(c => c.id === parseInt(req.params.id));
    if (!course) res.status(404).send('The course with the given id was not found.');
    res.send(course);
});

// PORT
const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`listening on port ${port}...`));

function validateCourse(course) {
    const schema = {
        name: Joi.string().min(3).required()
    };

    return Joi.validate(course, schema);
}
