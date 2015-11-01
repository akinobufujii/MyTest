class UsersController < ApplicationController
	def index
	end

	def show
		# 動的に変化させる
		@user = User.find_by(:username => params[:username])
	end
end
