# Linux File System

Linux has a single directory structure that starts from `/`, which is called the root directory. Everything in the Linux system exists somewhere under this root.

## 1. Linux Directory Tree

```text
/
├── bin      # essential binaries (ls, cp, bash)
├── etc      # system configuration files
├── home     # user home directories
├── var      # logs, spool, and changing data
├── tmp      # temporary files
├── proc     # virtual filesystem: kernel & processes
├── dev      # device files (sda, tty, null)
├── usr      # user programs and libraries
└── opt      # optional / third-party software
```

### Important Directories

- `/` → The root of the entire Linux filesystem
- `/bin` → Essential binaries and commands
- `/etc` → System configuration files
- `/home` → User home directories
- `/var` → Logs and other changing data
- `/tmp` → Temporary files
- `/proc` → Virtual filesystem containing kernel and process information
- `/dev` → Device files
- `/usr` → User programs and libraries
- `/opt` → Optional or third-party software

## 2. Navigation & Inspection

When working with Linux, we often need to move between directories and check what files and folders are inside them.

### Commands

```bash
# Show the current working directory
pwd

# List files with detailed information
ls -lah /etc

# Move to a directory
cd /var/log

# Move two levels up
cd ../..

# Go to the current user's home directory
cd ~
```

### Command Options

- `pwd` → Shows the current working directory
- `ls` → Lists files and directories
- `-l` → Shows detailed information
- `-a` → Shows hidden files
- `-h` → Shows human-readable file sizes
- `cd` → Changes the current directory
- `..` → Represents the parent directory
- `~` → Represents the current user's home directory

### Example

```text
/home/hanzala
```

This is an example of the output of `pwd`.

## 3. File Operations

Linux provides several commands for copying, moving, removing, searching, and checking files and directories.

### Commands

```bash
# Copy a directory recursively
cp -r src/ dest/

# Move or rename a file
mv old.txt new.txt

# Remove a directory recursively
rm -rf dir/

# Find .log files modified within the last 7 days
find / -name "*.log" -mtime -7

# Check the size of a directory
du -sh /var/log

# Check available and used disk space
df -h
```

### Command Options

- `cp -r` → Copies directories and their contents recursively
- `mv` → Moves or renames files/directories
- `rm -rf` → Removes directories and their contents
- `find` → Searches for files and directories
- `du -sh` → Shows the total disk usage of a directory
- `df -h` → Shows available and used disk space

> **Note:** Be careful with `rm -rf` because it can permanently delete files and directories.

## 4. Reading Files

Linux provides several commands for viewing and searching the contents of files. These commands are especially useful when working with configuration files and system logs.

### Commands

```bash
# Display the complete contents of a file
cat /etc/os-release

# Read a large file page by page
less /var/log/syslog

# Follow a file and display new lines as they are added
tail -f /var/log/syslog

# Search for "error" inside a file
grep "error" app.log
```

### Command Options

- `cat` → Displays the complete contents of a file
- `less` → Allows you to read large files page by page
- `tail -f` → Continuously monitors a file for new content
- `grep` → Searches for specific text inside a file

### Useful Keys

When using `less`:

```text
q → Quit
```

When using `tail -f`:

```text
Ctrl + C → Stop following the file
```

## What I Learned

I learned the basic structure of the Linux filesystem and how different directories are used. I also practiced navigating through directories, managing files and directories, checking disk usage, reading files, monitoring logs, and searching for specific text using Linux terminal commands.
