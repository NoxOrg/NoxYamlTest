# NoxYamlTest
a sample repo that demonstates how the Nox.solution yaml definition can be used in a project

The yaml definition is in the .nox/design folder.

It produces the following model:
```mermaid
erDiagram
    Person {
        AutoNumber Id PK
        Text Name
        Text LastName
    }
    Person ||--o{ Contact : "contacted at"
    Contact {
        AutoNumber Id PK
        Text Name
        PhoneNumber PhoneNumber
        Email Email
    }
```
It also demonstates how to use the $ref feature in a Nox yaml definition
```
domain:
  entities:
    - $ref: person.entity.nox.yaml
    
    - $ref: contact.entity.nox.yaml
```
