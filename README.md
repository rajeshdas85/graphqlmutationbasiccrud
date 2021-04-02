# graphqlmutationbasiccrud

Please find all the queries for this Demo 

query{
  groups{
    nodes{
      groupId
      name
      shortName
    }
  }
}
-----------------------------
query{
  groups{
    nodes{
      groupId
      name
      shortName
      students{
        studentID
        name
      }
    }
  }
}
---------------------------------
mutation{
  createStudent(inputStudent:{
    name:"Motor"
    groupId:1
  })
  {
    studentID
    name
  }
}
-----------------------------------
query{
students{
  nodes{
    studentID
    name
  }
}
}
-------------------------------------
mutation{
  deleteStudent(inputStudent:{
    studentId:3
  })
  {
    studentID
    name
  }
}
----------------------------------------
query{
students{
  nodes{
    studentID
    name
    groupId
  }
}
}