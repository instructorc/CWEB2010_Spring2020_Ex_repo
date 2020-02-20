const express = require('express')
const unique = require('uniq');
const app = express()
const port = 3000

app.get('/', (req, res) => {
    var namesArray = ["Chris", "Tom", "Bob", "Chris", "Chris"];

    var filteredArray = unique(namesArray).count();
    console.log(filteredArray);
    res.send('Hello World!');
});


app.listen(port, () => console.log(`Example app listening on port ${port}!`))