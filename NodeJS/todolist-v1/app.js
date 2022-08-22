//jshint esversion:6

const express = require("express");
const bodyParser = require("body-parser");
const date = require(__dirname + "/date.js");

const app = express();

app.set("view engine", "ejs");
app.use(bodyParser.urlencoded({
  extended: true
}));
app.use(express.static("public"));

var items = ["Buy Food", "Cook Food", "Eat Food"];
var workItems = [];

app.get("/", function(req, res) {

  // Creating new li item - would be usefull in creating new db items --- part 1
  res.render("list", {
    listTitle: date.getDate(),
    newListItem: items
  });
});

app.post("/", function(req, res) {

  // Creating new li item - would be usefull in creating new db items --- part 2
  let item = req.body.newItem;
  if (req.body.List === "work") {
    workItems.push(item);
    res.redirect("/work");
  } else {
    items.push(item);
    res.redirect("/");
  }

})

app.get("/work", function(req, res) {
  res.render("list", {
    listTitle: "work",
    newListItem: workItems
  })
})

app.post("/work", function(req, res) {

  let item = req.body.newItem;
  workItems.push(item);
  res.redirect("/work");
})

app.listen(3000, function() {
  console.log("Server started on port 3000.");
});
