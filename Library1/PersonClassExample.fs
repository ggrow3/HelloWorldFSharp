module File1

type Person(forename : string, surname:string) = 
    member __.forename = forename
    member __.surname = surname


    // let p1 = Person("Jane","Doe");;