

# homebrew to install the required tools: 
# http://mxcl.github.io/homebrew/index_de.html


ruby -e "$(curl -fsSL https://raw.github.com/mxcl/homebrew/go)"

brew install autoconf
brew install automake
brew install libtool
brew install gettext

brew link --force gettext