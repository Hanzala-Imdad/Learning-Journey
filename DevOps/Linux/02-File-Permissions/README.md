# Linux File Permissions

Linux uses file permissions to control who can read, write, or execute files and directories. Permissions are mainly assigned to the file owner, the group, and other users.

## `chmod`

`chmod` is used to change the permissions of a file or directory.

Permissions are commonly represented using three numbers called **octal permissions**.

For example:

```bash
chmod 755 script.sh
```

The three digits represent permissions for:

```text
Owner   Group   Others
  7       5       5
```

The numbers are based on:

```text
4 = read (r)
2 = write (w)
1 = execute (x)
```

For example:

```text
7 = 4 + 2 + 1 = rwx
6 = 4 + 2     = rw-
5 = 4 + 1     = r-x
4 = 4         = r--
0 = --------
```

## Common `chmod` Commands

```bash
# Give owner full permissions and read/execute to group and others
chmod 755 script.sh

# Owner can read/write, group and others can only read
chmod 644 config.txt

# Only the owner can read and write
chmod 600 id_rsa

# Add execute permission
chmod +x deploy.sh

# Apply permissions recursively to a directory
chmod -R 755 www/
```

### Understanding Common Permissions

```text
755 → rwxr-xr-x
644 → rw-r--r--
600 → rw-------
```

For example:

```bash
chmod 755 script.sh
```

means:

```text
Owner  → read + write + execute
Group  → read + execute
Others → read + execute
```

## `chown`

`chown` is used to change the owner and group of a file or directory.

```bash
chown ali:devs file
```

In this example:

```text
ali  → new owner
devs → new group
file → target file
```

## Important Note

Be careful when changing permissions, especially when using `chmod -R`, because it applies the permission change to everything inside the directory.

## What I Learned

I learned how Linux uses permissions to control access to files and directories. I practiced using `chmod` with octal values such as `755`, `644`, and `600`, and learned how `chown` is used to change file ownership and groups.
