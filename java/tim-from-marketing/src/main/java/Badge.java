class Badge {
    public String print(Integer id, String name, String department) {
        String thisId = "";
        if (id != null) {
            thisId = "[" + id + "] - ";
        }

        if (department == null) {
            department = "owner";
        }

        return  thisId + name + " - " + department.toUpperCase();
    }
}
