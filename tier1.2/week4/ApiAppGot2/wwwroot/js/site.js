const uri = 'api/goTCharacters';
let characters = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addCharacter() {

    // HTML form element constansts 
    const addNameTextbox = document.getElementById('add-name');
    const addDescriptionTextbox = document.getElementById('add-description');
    const addAllegianceTextbox = document.getElementById('add-allegiance');

    // HTML form values 
    const addNameValue = addNameTextbox.value.trim();
    let addDescriptionValue = addDescriptionTextbox.value.trim();
    let addAllegianceValue = addAllegianceTextbox.value.trim();

    // validate name, if blank then the form is rejected
    if (isBlank(addNameValue)) {
        alert("Name can not be blank. Try again.");
        return;
    };

    // validate description, if blank then add default description
    if (isBlank(addDescriptionValue)) {
        addDescriptionValue = "Dragon food...";
    };

    // validate allegiance, if blank then add default allegiance
    if (isBlank(addAllegianceValue)) {
        addAllegianceValue = "Unlcear."
    };

    const item = {
        name: addNameValue,
        description: addDescriptionValue,
        allegiance: addAllegianceValue
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
            addDescriptionTextbox.value = '';
            addAllegianceTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const character = characters.find(character => character.id === id);

    document.getElementById('edit-id').value = character.id;
    document.getElementById('edit-name').value = character.name;
    document.getElementById('edit-description').value = character.description;
    document.getElementById('edit-allegiance').value = character.allegiance;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        name: document.getElementById('edit-name').value.trim(),
        description: document.getElementById('edit-description').value.trim(),
        allegiance: document.getElementById('edit-allegiance').value.trim()
    };

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'Character' : 'Character';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('characters');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let nameTextNode = document.createTextNode(item.name);
        td1.appendChild(nameTextNode); const uri = 'api/goTCharacters';
        let characters = [];

        function getItems() {
            fetch(uri)
                .then(response => response.json())
                .then(data => _displayItems(data))
                .catch(error => console.error('Unable to get items.', error));
        }

        function addCharacter() {

            // HTML form element constansts 
            const addNameTextbox = document.getElementById('add-name');
            const addDescriptionTextbox = document.getElementById('add-description');
            const addAllegianceTextbox = document.getElementById('add-allegiance');

            // HTML form values 
            const addNameValue = addNameTextbox.value.trim();
            let addDescriptionValue = addDescriptionTextbox.value.trim();
            let addAllegianceValue = addAllegianceTextbox.value.trim();

            // validate name, if blank then the form is rejected
            if (isBlank(addNameValue)) {
                alert("Name can not be blank. Try again.");
                return;
            };

            // validate description, if blank then add default description
            if (isBlank(addDescriptionValue)) {
                addDescriptionValue = "Dragon food...";
            };

            // validate allegiance, if blank then add default allegiance
            if (isBlank(addAllegianceValue)) {
                addAllegianceValue = "Unlcear."
            };

            const item = {
                name: addNameValue,
                description: addDescriptionValue,
                allegiance: addAllegianceValue
            };

            fetch(uri, {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(item)
            })
                .then(response => response.json())
                .then(() => {
                    getItems();
                    addNameTextbox.value = '';
                    addDescriptionTextbox.value = '';
                    addAllegianceTextbox.value = '';
                })
                .catch(error => console.error('Unable to add item.', error));
        }

        function deleteItem(id) {
            fetch(`${uri}/${id}`, {
                method: 'DELETE'
            })
                .then(() => getItems())
                .catch(error => console.error('Unable to delete item.', error));
        }

        function displayEditForm(id) {
            const character = characters.find(character => character.id === id);

            document.getElementById('edit-id').value = character.id;
            document.getElementById('edit-name').value = character.name;
            document.getElementById('edit-description').value = character.description;
            document.getElementById('edit-allegiance').value = character.allegiance;
            document.getElementById('editForm').style.display = 'block';
        }

        function updateItem() {
            const itemId = document.getElementById('edit-id').value;
            const item = {
                id: parseInt(itemId, 10),
                name: document.getElementById('edit-name').value.trim(),
                description: document.getElementById('edit-description').value.trim(),
                allegiance: document.getElementById('edit-allegiance').value.trim()
            };

            fetch(`${uri}/${itemId}`, {
                method: 'PUT',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(item)
            })
                .then(() => getItems())
                .catch(error => console.error('Unable to update item.', error));

            closeInput();

            return false;
        }

        function closeInput() {
            document.getElementById('editForm').style.display = 'none';
        }

        function _displayCount(itemCount) {
            const name = (itemCount === 1) ? 'Character' : 'Character';

            document.getElementById('counter').innerText = `${itemCount} ${name}`;
        }

        function _displayItems(data) {
            const tBody = document.getElementById('characters');
            tBody.innerHTML = '';

            _displayCount(data.length);

            const button = document.createElement('button');

            data.forEach(item => {

                let editButton = button.cloneNode(false);
                editButton.innerText = 'Edit';
                editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

                let deleteButton = button.cloneNode(false);
                deleteButton.innerText = 'Delete';
                deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

                let tr = tBody.insertRow();

                let td1 = tr.insertCell(0);
                let nameTextNode = document.createTextNode(item.name);
                td1.appendChild(nameTextNode);

                let td2 = tr.insertCell(1);
                let descriptionTextNode = document.createTextNode(item.description);
                td2.appendChild(descriptionTextNode);

                let td3 = tr.insertCell(2);
                let allegianceTextNode = document.createTextNode(item.allegiance);
                td3.appendChild(allegianceTextNode);

                let td4 = tr.insertCell(3);
                td4.appendChild(editButton);

                let td5 = tr.insertCell(4);
                td5.appendChild(deleteButton);
            });

            characters = data;
        }
        function isBlank(entry) {
            if (entry === "" || entry === null) {
                return true;
            }
            else return false;
        };

        let td2 = tr.insertCell(1);
        let descriptionTextNode = document.createTextNode(item.description);
        td2.appendChild(descriptionTextNode);

        let td3 = tr.insertCell(2);
        let allegianceTextNode = document.createTextNode(item.allegiance);
        td3.appendChild(allegianceTextNode);

        let td4 = tr.insertCell(3);
        td4.appendChild(editButton);

        let td5 = tr.insertCell(4);
        td5.appendChild(deleteButton);
    });

    characters = data;
}
function isBlank(entry) {
    if (entry === "" || entry === null) {
        return true;
    }
    else return false;
};