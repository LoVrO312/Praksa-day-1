document.getElementById("subjectForm").addEventListener("submit", function(event)
{
    event.preventDefault();
    insertSubject();
});

function insertSubject()
{
    let subjectName = document.getElementById("SubjectName").value;
    let numberOfEcts = document.getElementById("NumberOfEcts").value;
    let departmentId = document.getElementById("DepartmentId").value;
    let timeCreated = document.getElementById("TimeCreated").value;

    let subjects = JSON.parse(localStorage.getItem("subjects")) || [];
    let lastId = subjects.length > 0 ? subjects[subjects.length - 1].id : 0;

    const newSubject = {
        id: lastId + 1,
        name: subjectName,
        numberOfEcts: numberOfEcts,
        departmentId: departmentId,
        timeCreated: timeCreated
    };

    subjects.push(newSubject);
    localStorage.setItem("subjects", JSON.stringify(subjects));
    refreshTable();
}

function updateSubject(id)
{
    let subjects = JSON.parse(localStorage.getItem("subjects")) || [];
    const subjectToUpdate = subjects.find(sub => sub.id === id);

    if (subjectToUpdate)
    {
        if(document.getElementById("SubjectName").value)
            subjectToUpdate.name = document.getElementById("SubjectName").value;
        if(document.getElementById("NumberOfEcts").value)
            subjectToUpdate.numberOfEcts = document.getElementById("NumberOfEcts").value;
        if(document.getElementById("DepartmentId").value)
            subjectToUpdate.departmentId = document.getElementById("DepartmentId").value;
        if(document.getElementById("TimeCreated").value)
            subjectToUpdate.timeCreated = document.getElementById("TimeCreated").value;

        localStorage.setItem("subjects", JSON.stringify(subjects));
        refreshTable();
    }
}

function deleteSubject(id)
{
    let subjects = JSON.parse(localStorage.getItem("subjects")) || [];

    subjects = subjects.filter(sub => sub.id !== id);
    localStorage.setItem("subjects", JSON.stringify(subjects));
    refreshTable();
}


function refreshTable()
{
    const tableBody = document.getElementById("subjectTableBody");
    tableBody.innerHTML = "";

    let subjects = JSON.parse(localStorage.getItem("subjects")) || [];

    subjects.forEach(subject =>
    {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${subject.id}</td>
            <td>${subject.name}</td>
            <td>${subject.numberOfEcts}</td>
            <td>${subject.departmentId}</td>
            <td>${subject.timeCreated}</td>
            <td>
                <button class="updateBtn" data-id="${subject.id}">Update</button>
                <button class="deleteBtn" data-id="${subject.id}">Delete</button>
            </td>
        `;
        tableBody.appendChild(row);
    });

    document.querySelectorAll(".updateBtn").forEach(button =>  // use . in .updateBtn to select by class, without the . it would select by tag name
    {
        button.addEventListener("click", function()
        {
            const subjectId = parseInt(this.getAttribute("data-id"));
            updateSubject(subjectId);
        });
    });

    document.querySelectorAll(".deleteBtn").forEach(button =>
    {
        button.addEventListener("click", function()
        {
            const subjectId = parseInt(this.getAttribute("data-id"));
            deleteSubject(subjectId);
        });
    });
}

