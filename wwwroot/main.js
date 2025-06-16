console.log("JS loaded")

// Find element
const element = document.querySelector("#example")
element.textContent = "Something different"

const response = await fetch("/hello")
const body = await response.text()
element.textContent = body
